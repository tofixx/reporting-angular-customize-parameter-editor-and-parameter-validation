import { Component, Input } from "@angular/core";
import { IEditorViewModel } from "@devexpress/analytics-core/analytics-widgets-native";
import { DxDateRangeBoxModule, DxValidatorModule } from "devextreme-angular";

@Component({
  selector: "app-custom-date-range-input",
  standalone: false,
  templateUrl: "./custom-date-range-input.component.html",
  styleUrl: "./custom-date-range-input.component.less",
})
export class CustomDateRangeInputComponent {
  @Component({
    selector: "custom-input-component",
    templateUrl: "custom.input.component.html",
  })
  @Input()
  data!: IEditorViewModel; // enable two-way-binding on data.value in html file: [(value)]="data.value"

  now = new Date();
  min: string | number | Date;
  max: string | number | Date;

  constructor() {
    this.min = new Date(this.now.getFullYear(), 0, 1);
    this.max = new Date(this.now.getFullYear(), 11, 31);
  }
}
