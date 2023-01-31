import { VehicleService } from '../services/vehicle.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cars-form',
  templateUrl: './cars-form.component.html',
  styleUrls: ['./cars-form.component.css']
})
export class CarsFormComponent implements OnInit {
public makes: any;
models: any= [];
public vehicle: any ={};
features: any[]=[];

  constructor(private vehicleService : VehicleService) { }

  ngOnInit() 
  {
            this.vehicleService.getMakes().subscribe(makes=> 
             { this.makes= makes;  });

              this.vehicleService.getFeatures().subscribe(features => 
              this.features = features)

              document.body.classList.add('bg-img');
   }


 onMakeChange() {
    console.log("VEHICLE", this.vehicle);
    var selectedMake=this.makes.find((m: { id: any; }) =>m.id==this.vehicle.makeId);
    this.models=selectedMake ? selectedMake.models : [];

}
}