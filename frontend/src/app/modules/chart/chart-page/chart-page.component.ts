import {Component, OnInit, ViewChild} from '@angular/core';
import {BaseChartDirective} from "ng2-charts";
import {ChartConfiguration, ChartData, ChartEvent, ChartType} from "chart.js";

import DataLabelsPlugin from 'chartjs-plugin-datalabels';
import {ChartService} from "../../../core/services/chart.service";
import {BaseComponent} from "../../../core/base/base.component";
import {takeUntil} from "rxjs";

@Component({
  selector: 'app-chart-page',
  templateUrl: './chart-page.component.html',
  styleUrls: ['./chart-page.component.sass']
})
export class ChartPageComponent extends BaseComponent implements OnInit {
  @ViewChild(BaseChartDirective) chart: BaseChartDirective | undefined;

  public barChartOptions: ChartConfiguration['options'] = {
    responsive: true,
    scales: {
      x: {},
      y: {
        min: 0,
      },
    },
    plugins: {
      legend: {
        display: true,
      },
      datalabels: {
        anchor: 'start',
        align: 'end',
      },
    },
  };
  public barChartType: ChartType = 'bar';
  public barChartPlugins = [DataLabelsPlugin];

  public barChartData: ChartData<'bar'> = {
    labels: ['2006', '2007', '2008', '2009', '2010', '2011', '2012'],
    datasets: [
      {data: [65, 59, 80, 81, 56, 55, 40], label: 'Series A'},
    ],
  };

  constructor(private chartService: ChartService) {
    super();
  }

  public ngOnInit() {
    this.loadData();
  }

  private loadData() {
    this.chartService.getBarChartData()
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe({
        next: barData => {
          this.barChartData = {
            labels: barData.labels,
            datasets: [
              {data: barData.data, label: 'Books per year'},
            ],
          };
        }
      })
  }
}
