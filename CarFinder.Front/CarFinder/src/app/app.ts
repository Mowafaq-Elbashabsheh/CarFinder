import { Component } from '@angular/core';
import { RouterOutlet, Router  } from '@angular/router';
import { CarsService } from './services/cars.service';
import { FormsModule } from '@angular/forms';
import { DataTransferService } from './services/data-transfer.service';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, FormsModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'CarFinder';
  search_makeId!: number;
  search_modelYear!: number;
  
  constructor(private carsService: CarsService, private dataTransferService: DataTransferService, private router: Router) {}

  search() {
    this.carsService.GetModelsForMakeId(this.search_makeId, this.search_modelYear).subscribe({
      next: (response:any) => {
        this.dataTransferService.setData(response.results); //{"make_ID": 474,"make_Name": "HONDA","model_ID": 1861,"model_Name": "Accord"}
        this.router.navigate(['/makeModels']);
      },
      error: (errResponse:any) => {
        console.warn(errResponse)
      }
    })
  }

  get CanSearch(): boolean {
    return !(this.search_makeId > 0 && this.search_modelYear > 0);
  }
}
