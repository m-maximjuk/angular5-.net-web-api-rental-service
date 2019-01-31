import { RouterModule }   from '@angular/router';
import { NgModule }       from '@angular/core';
import { CommonModule }   from '@angular/common';
import { SharedModule }   from './_Shared/Shared.module';
import { MainModule }     from './Main/Main.module';
import { AccountModule }  from './Account/Account.module';
import { VehiclesModule } from './Vehicles/Vehicles.module';

import { AppComponent }    from './app.component';
import { NavbarComponent } from './Navbar/Navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule,
    AccountModule,
    MainModule,
    VehiclesModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
