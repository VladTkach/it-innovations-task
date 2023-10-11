import { NgModule } from '@angular/core';
import {RouterModule, Routes} from "@angular/router";

const routes: Routes = [
  {
    path: 'book',
    loadChildren: () => import('src/app/modules/books/books.module').then((m) => m.BooksModule),
  },
  {
    path: 'chart',
    loadChildren: () => import('src/app/modules/chart/chart.module').then((m) => m.ChartModule),
  },
  { path: '', redirectTo: '/book', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
