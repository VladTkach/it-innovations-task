import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor, HttpErrorResponse
} from '@angular/common/http';
import {catchError, Observable} from 'rxjs';
import {ToastrService} from "ngx-toastr";

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

  constructor(private toastr: ToastrService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    return next.handle(request).pipe(
      catchError((error: HttpErrorResponse) => {
        if (error){
          console.log(error)
          switch (error.status){
            case 400:
              if (error.error.errors){
                const modalStatErrors = [];
                for (const key in error.error.errors){
                  console.log(error.error.errors[key])
                  if (error.error.errors[key]){
                    modalStatErrors.push(error.error.errors[key])
                  }
                }
                this.toastr.error(modalStatErrors.join('\n'));
                throw modalStatErrors.flat();
              } else {
                this.toastr.error(error.error, error.status.toString());
              }
              break;
            default:
              this.toastr.error('Something unexpected went wrong');
              console.log(error);
              break;
          }
        }
        throw error.message;
      })
    );
  }
}
