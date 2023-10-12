import { Injectable } from '@angular/core';
import {HttpInternalService} from "./http-internal.service";
import {BarChart} from "../../models/chart/bar-chart";

@Injectable({
  providedIn: 'root'
})
export class ChartService {
  private routePrefix = '/api/chart';
  constructor(private httpService: HttpInternalService) { }

  public getBarChartData(){
    return this.httpService.getRequest<BarChart>(`${this.routePrefix}/bar`);
  }
}
