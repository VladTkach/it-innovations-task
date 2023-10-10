import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BooksRoutingModule } from './books-routing.module';
import { BooksPageComponent } from './books-page/books-page.component';
import { BookDetailsComponent } from './book-details/book-details.component';
import {MaterialModule} from "../../material/material.module";


@NgModule({
  declarations: [
    BooksPageComponent,
    BookDetailsComponent
  ],
  imports: [
    CommonModule,
    BooksRoutingModule,
    MaterialModule
  ]
})
export class BooksModule { }
