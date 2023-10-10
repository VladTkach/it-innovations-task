import { Injectable } from '@angular/core';
import {HttpInternalService} from "./http-internal.service";
import {BookDto} from "../../models/book/book-dto";

@Injectable({
  providedIn: 'root'
})
export class BookService {
  private routePrefix = '/api/book';
  constructor(private httpService: HttpInternalService) { }

  public getAllBooks(){
    return this.httpService.getRequest<BookDto[]>(`${this.routePrefix}/all`);
  }
}