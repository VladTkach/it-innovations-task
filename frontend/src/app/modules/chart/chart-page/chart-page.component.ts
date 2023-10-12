import {Component, OnInit, ViewChild} from '@angular/core';
import {BaseChartDirective} from "ng2-charts";
import {ChartData} from "chart.js";

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

  public barChartData?: ChartData<'bar'>;

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
              {data: barData.data, label: 'Books per year', backgroundColor: 'rgba(35,35,253,0.8)'},
            ],
          };
        }
      })
  }
}
