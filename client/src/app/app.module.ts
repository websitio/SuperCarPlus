import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { VehicleService } from './components/services/vehicle.service';

import { ErrorHandler, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { CarsFormComponent } from './components/cars-form/cars-form.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './components/home/home.component';
import { routes } from './app-routing.module';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';
import { ErrorInterceptor } from './shared/interceptors/error.interceptor';
import { AppErrorHandler } from './shared/errors/app.error-handler';



@NgModule({
  declarations: [
    AppComponent,
    CarsFormComponent,
    NavbarComponent,
    HomeComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    
    RouterModule.forRoot(routes),
    ToastrModule.forRoot({
      positionClass: 'toastr-top-right'     })
  ],
  exports: [ToastrModule],
  providers: [
    {provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true  },
    { provide: ErrorHandler, useClass: AppErrorHandler },
          VehicleService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
