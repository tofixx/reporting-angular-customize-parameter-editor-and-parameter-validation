import {
  Component,
  Inject,
  ViewChild,
  ViewEncapsulation,
  TemplateRef,
  inject,
} from "@angular/core";
import { CustomDateRangeInputComponent } from "../custom-date-range-input/custom-date-range-input.component";
import { TemplateEngine } from "devexpress-reporting-angular/dx-report-viewer";
import { ValidationCallbackData } from "devextreme/common";

@Component({
  selector: "report-viewer",
  encapsulation: ViewEncapsulation.None,
  templateUrl: "./report-viewer.html",
  styleUrls: [
    "../../../node_modules/devextreme/dist/css/dx.material.blue.light.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.common.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.material.blue.light.css",
    "../../../node_modules/devexpress-reporting/dist/css/dx-webdocumentviewer.css",
  ],
})
export class ReportViewerComponent {
  reportUrl: string = "CustomParameterReport";
  invokeAction: string = "/DXXRDV";
  public _templateEngine = inject(TemplateEngine);

  @ViewChild("customDateRangeTemplateRef")
  customDateRangeTemplateRef!: TemplateRef<{ data: any }>;

  @ViewChild(CustomDateRangeInputComponent)
  customDateRangeInput!: CustomDateRangeInputComponent;

  ngAfterViewInit(): void {
    this._templateEngine.register(
      "custom-date-range-input",
      this.customDateRangeTemplateRef
    );
  }
  onCustomizeParameterEditors(event): void {
    const parameter = event.args.parameter;
    const info = event.args.info;
    if (!Array.isArray(info.validationRules)) {
      info.validationRules = [];
    }
    // validate multi-value parameter to ensure at least one value is selected
    if (parameter.multiValue && parameter.allowNull !== true) {
      info.validationRules.push({
        type: "required",
        message: "Mindestens ein Eintrag muss ausgewählt werden.",
      });
    }
    if (parameter.type === "CustomParameterType") {
      info.validationRules = info.validationRules || [];
      info.validationRules.push({
        type: "email",
        message: "Email parameter value has invalid format.",
      });
      info.editor.header = "custom-parameter-text-editor";
    }

    if (
      parameter.type === "System.DateTime" &&
      "Start" in parameter.value &&
      "End" in parameter.value
    ) {
      // this is a date range parameter, change the template to enable validation
      info.editor.header = "custom-date-range-input";
      // add daterange validation rules here or
      // set default rules in the custom-date-range-input component...
      const customValidationRule = {
        type: "custom",
        message: "The sum of months should be eager.",
        reevaluate: true,
        validationCallback: (e: ValidationCallbackData) => {
          const { value } = e;
          if (
            value.length === 2 &&
            value[0] instanceof Date &&
            value[1] instanceof Date &&
            value[0] <= value[1]
          ) {
            const sum_eager =
              (value[0] as Date).getMonth() +
              1 +
              ((value[1] as Date).getMonth() + 1);
            const res = sum_eager % 2 === 0;
            return res;
          }
          return false;
        },
      };
      info.validationRules.push(customValidationRule);
    }
  }

  ParametersSubmitted($event: any) {
    if (this.customDateRangeInput) {
      const restDate = (jsDate: Date) => {
        // add timezone offset (hours) to date to avoid day shift in server
        const timezoneOffsetMinutes = jsDate.getTimezoneOffset();
        const adjustedDate = new Date(
          jsDate.getTime() - timezoneOffsetMinutes * 60000
        );
        return adjustedDate;
      };
      const rangeparam = $event.args.Parameters.filter(
        (x) => x.Key === "daterange"
      )[0];
      const startDate = this.customDateRangeInput.data.value[0];
      const endDate = this.customDateRangeInput.data.value[1];
      const timeRangeRest = [restDate(startDate), restDate(endDate)];
      rangeparam.Value = timeRangeRest;
    }
  }

  constructor(@Inject("BASE_URL") public hostUrl: string) {}
}
