import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Make } from '../models/make';
import { Feature } from '../models/Feature';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {

  constructor(private http: HttpClient) { }

// getMakes(){
//   return  this.http.get('api/makes') 
//   .map(res=>res.json());

getMakes()
{
  return  this.http.get<Make[]>('https://localhost:7004/api/makes') ;
}

getFeatures()
{
  return  this.http.get<Feature[]>('https://localhost:7004/api/features') ;
}


  
}


