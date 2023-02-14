import { VehicleService } from '../services/vehicle.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-cars-form',
  templateUrl: './cars-form.component.html',
  styleUrls: ['./cars-form.component.css']
})
export class CarsFormComponent implements OnInit {
public makes: any;
public models: any= [];
public vehicle: any ={
  features:[],
  contact:{}
};
public features: any[]=[];
vehiclesForm!: FormGroup;

  constructor(private vehicleService : VehicleService, private toastr: ToastrService) { }

  ngOnInit() 
  {
            this.vehicleService.getMakes().subscribe(makes=> 
             { this.makes= makes;  });

              this.vehicleService.getFeatures().subscribe(features => 
              this.features = features)

              document.body.classList.add('bg-img');

          //    this.initializeForm();
   }

   initializeForm(){
  this.vehiclesForm= new FormGroup({
make: new FormControl(),
model: new FormControl(),
registered : new FormControl(),
feature: new FormControl(),
contactName : new FormControl(),
contactEmail : new FormControl()
  })
  
  }

submit()
{
throw Error();
;
//   this.vehicleService.create(this.vehicle).subscribe(
//    x=> console.log(x),
//  err=>{
//   console.log(err);
//    this.toastr.error(err.error);
// }                                  
//  )


};






onFeatureToggle(featureId: any, $event: any){
if($event.target.checked)

this.vehicle.features.push(featureId);
else {
var index= this.vehicle.features.indexOf(featureId);
this.vehicle.features.splice(index,1)
}
  
  }


 onMakeChange() {
    console.log("VEHICLE", this.vehicle);
    var selectedMake=this.makes.find((m: { id: any; }) =>m.id==this.vehicle.makeId);
    this.models=selectedMake ? selectedMake.models : [];
    delete this.vehicle.modelId;






  }
}