import { NgModule }     from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { DashboardComponent }     from './Dashboard.component';
import { AdminComponent }         from './Admin/Admin.component';
import { CustomerComponent }      from './Customer/Customer.component';
import { OrdersComponent }        from './Customer/Orders/Orders.component';
import { EmployeeComponent }      from './Employee/Employee.component';
import { AccountsComponent }      from './Admin/Accounts/Accounts.component';
import { ManufacturersComponent } from './Admin/Manufacturers/Manufacturers.component';
import { ProfileComponent }       from '../../Vehicles/Profile/Profile.component';
import { VehiclesComponent }      from './Admin/Vehicles/Vehicles.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot([
      { path: "Dashboard",                     component: DashboardComponent },
      { path: "Dashboard/Admin",               component: AdminComponent },
      { path: "Dashboard/Admin/Profile",       component: ProfileComponent },
      { path: "Dashboard/Admin/Orders",        component: OrdersComponent },
      { path: "Dashboard/Admin/Manufacturers", component: ManufacturersComponent },
      { path: "Dashboard/Admin/Vehicles",      component: VehiclesComponent },
      { path: "Dashboard/Customer",            component: CustomerComponent },
      { path: "Dashboard/Customer/Profile",    component: ProfileComponent },
      { path: "Dashboard/Customer/Orders",     component: OrdersComponent },
      { path: "Dashboard/Employee",            component: EmployeeComponent },
      { path: "Dashboard/Employee/Profile",    component: EmployeeComponent },
      { path: "Dashboard/Employee/Orders",     component: OrdersComponent },
    ])
  ],
  declarations: [
    DashboardComponent,
    AdminComponent,
    EmployeeComponent,
    CustomerComponent,
    OrdersComponent,
    AccountsComponent,
    ManufacturersComponent,
    VehiclesComponent
],
  providers: [],
  exports:   [DashboardComponent]
})
export class DashboardModule { }