import { NgModule }     from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

import { ManufacturersComponent } from './Manufacturers/Manufacturers.component';
import { VehiclesComponent }      from './Vehicles.component';
import { OrderComponent }         from './Order/Order.component';
import { PriceComponent }         from './Price/Price.component';
import { ProfileComponent }       from './Profile/Profile.component';
import { ModelsComponent }        from './Models/Models.component';
import { DetailsComponent }       from './Details/Details.component';
import { DataService }            from '../_Shared/Services/Data.service';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule.forRoot([
      { path: "Vehicles",                component: VehiclesComponent },
      { path: "Vehicles/Manufacturers",  component: ManufacturersComponent },
      { path: "Vehicles/Models",         component: ModelsComponent },
      { path: "Vehicles/Models/Profile", component: ProfileComponent },
      { path: "Vehicles/Order",          component: OrderComponent},

    ])
  ],
  declarations: [
    VehiclesComponent,
    ManufacturersComponent,
    OrderComponent,
    PriceComponent,
    ProfileComponent,
    ModelsComponent,
    DetailsComponent
],
  providers: [DataService],
  exports:   [VehiclesComponent, ManufacturersComponent, ModelsComponent, ProfileComponent, OrderComponent],
})
export class VehiclesModule { }