import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ChartRoutingModule } from './chart-routing.module';
import { ChartPageComponent } from './chart-page/chart-page.component';
import {NgChartsModule} from "ng2-charts";
import {MaterialModule} from "../../material/material.module";


@NgModule({
  declarations: [
    ChartPageComponent
  ],
  imports: [
    CommonModule,
    ChartRoutingModule,
    NgChartsModule,
    MaterialModule
  ]
})
export class ChartModule { }
