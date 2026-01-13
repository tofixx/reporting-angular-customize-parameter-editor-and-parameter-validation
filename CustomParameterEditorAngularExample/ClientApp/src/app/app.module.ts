import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";

import { AppComponent } from "./app.component";
import { NavMenuComponent } from "./navmenu/nav-menu.component";
import { HomeComponent } from "./home/home.component";
import {
  DxReportViewerModule,
  DxReportDesignerModule,
} from "devexpress-reporting-angular";
import { ReportViewerComponent } from "./reportviewer/report-viewer";

import { DxDateRangeBoxModule, DxTextBoxModule } from "devextreme-angular";
import { DxValidatorModule } from "devextreme-angular";

import { CustomInputComponent } from "./custominputcomponent/custom.input.component";
import { CustomDateRangeInputComponent } from "./custom-date-range-input/custom-date-range-input.component";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ReportViewerComponent,
    CustomInputComponent,
    CustomDateRangeInputComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    HttpClientModule,
    FormsModule,
    DxReportViewerModule,
    RouterModule.forRoot([
      { path: "", component: HomeComponent, pathMatch: "full" },
      { path: "DocumentViewer", component: ReportViewerComponent },
    ]),
    DxTextBoxModule,
    DxDateRangeBoxModule,
    DxValidatorModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
