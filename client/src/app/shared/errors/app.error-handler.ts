import { ToastrService } from 'ngx-toastr';
import { ErrorHandler, Inject, Injectable } from '@angular/core';

@Injectable()
export class AppErrorHandler implements ErrorHandler {

constructor(@Inject(ToastrService) private toastr: ToastrService) {}


  handleError(error: any): void {
    console.log("ERROR");
        this.toastr.error('An unexpected error happened');

  }
}