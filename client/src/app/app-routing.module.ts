import { Routes } from '@angular/router';


import { HomeComponent } from './components/home/home.component';
import { CarsFormComponent } from './components/cars-form/cars-form.component';

export const routes: Routes = [
{path: 'home', component: HomeComponent},
{path: 'vehicles/new', component: CarsFormComponent},
{path: '**',  redirectTo: 'home',  pathMatch: 'full'},
];

