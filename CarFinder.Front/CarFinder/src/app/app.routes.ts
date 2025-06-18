import { Routes } from '@angular/router';
import { CarMake } from './car-make/car-make';
import { CarType } from './car-type/car-type';
import { CarModels } from './car-models/car-models';

export const routes: Routes = [
    { path: '', component: CarMake},
    { path: 'makeTypes/:id', component: CarType},
    { path: 'makeModels', component: CarModels }
];
