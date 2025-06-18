import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Globals } from '../common/globals';

@Injectable({
  providedIn: 'root'
})
export class CarsService {

  constructor(private http: HttpClient) { }

  GetAllMakes(){
    return this.http.get(Globals.apiUrl + '/Cars/GetAllMakes')
  }

  GetVehicleTypesForMakeById(make_ID:any){
    return this.http.get(Globals.apiUrl + `/Cars/GetVehicleTypesForMakeById?id=${make_ID}`)
  }

  GetModelsForMakeId(make_ID:any, year:any){
    return this.http.get(Globals.apiUrl + `/Cars/GetModelsForMakeId?id=${make_ID}&year=${year}`)
  }
}
