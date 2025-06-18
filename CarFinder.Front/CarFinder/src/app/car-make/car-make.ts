import { Component } from '@angular/core';
import { CarsService } from '../services/cars.service';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-car-make',
  imports: [CommonModule, RouterModule],
  templateUrl: './car-make.html',
  styleUrl: './car-make.css'
})
export class CarMake {
  carMakes: any[] = [];

  constructor(private carsService: CarsService) {}

  ngOnInit() {
    this.GetAllMakes();
  }

  GetAllMakes(){
    this.carsService.GetAllMakes().subscribe({
      next: (response:any) => {
        this.carMakes = response.results; // make_ID, make_Name
      },
      error: (errResponse:any) => {
        console.warn(errResponse)
      }
    })
  }
}
