import { Injectable } from '@angular/core';
import {HttpInternalService} from "./http-internal.service";
import {BookDto} from "../../models/book/book-dto";
import {CreateBookDto} from "../../models/book/create-book-dto";
import {UpdateBookDto} from "../../models/book/update-book-dto";

@Injectable({
  providedIn: 'root'
})
export class BookService {
  private routePrefix = '/api/book';
  constructor(private httpService: HttpInternalService) { }

  public getAllBooks(){
    return this.httpService.getRequest<BookDto[]>(`${this.routePrefix}/all`);
  }

  public createBook(newBook: CreateBookDto){
    return this.httpService.postRequest<BookDto>(this.routePrefix, newBook);
  }

  public updateBook(newBook: UpdateBookDto){
    return this.httpService.putRequest<BookDto>(this.routePrefix, newBook);
  }

  public deleteBook(bookId: number){
    return this.httpService.deleteRequest(`${this.routePrefix}/${bookId}`);
  }
}
