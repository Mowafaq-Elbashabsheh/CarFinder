import { Component } from '@angular/core';
import { DataTransferService } from '../services/data-transfer.service';
import { Router, NavigationEnd  } from '@angular/router';
import { filter } from 'rxjs/operators';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-car-models',
  imports: [CommonModule],
  templateUrl: './car-models.html',
  styleUrl: './car-models.css'
})
export class CarModels {
  carModels: any[] = [];

  constructor(private dataTransferService: DataTransferService, private router: Router) {}

  ngOnInit(){
    this.loadData();

    this.router.events
      .pipe(filter(event => event instanceof NavigationEnd))
      .subscribe(() => {
        this.loadData();
      });
  }

  loadData() {
    var data = this.dataTransferService.getData();
    if (data) {
      this.carModels = data;
      this.dataTransferService.clear();
    }
  }
}
