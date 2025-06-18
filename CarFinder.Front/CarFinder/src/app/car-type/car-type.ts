import { Component } from '@angular/core';
import { CarsService } from '../services/cars.service';
import { ActivatedRoute } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-car-type',
  imports: [CommonModule],
  templateUrl: './car-type.html',
  styleUrl: './car-type.css'
})
export class CarType {
  makeTypes: any[] = [];
  constructor(private carsService: CarsService, private route: ActivatedRoute) {}

  ngOnInit() {
    const makeId = this.route.snapshot.paramMap.get('id');
    if(makeId){
      this.GetVehicleTypesForMakeById(makeId);
    }
  }

  GetVehicleTypesForMakeById(makeId:any){
    this.carsService.GetVehicleTypesForMakeById(makeId).subscribe({
      next: (response:any) => {
        this.makeTypes = response.results; //vehicleTypeId, vehicleTypeName
      },
      error: (errResponse:any) => {
        console.warn(errResponse)
      }
    })
  }
}
