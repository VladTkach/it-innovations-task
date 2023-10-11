import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ChartRoutingModule } from './chart-routing.module';
import { ChartPageComponent } from './chart-page/chart-page.component';


@NgModule({
  declarations: [
    ChartPageComponent
  ],
  imports: [
    CommonModule,
    ChartRoutingModule
  ]
})
export class ChartModule { }
