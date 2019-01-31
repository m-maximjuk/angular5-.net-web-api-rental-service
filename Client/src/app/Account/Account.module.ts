import { NgModule }        from '@angular/core';
import { CommonModule }    from '@angular/common';
import { HttpModule }      from '@angular/http';
import { FormsModule }     from '@angular/forms';
import { RouterModule }    from '@angular/router';
import { DashboardModule } from './Dashboard/Dashboard.module';

import { AccountComponent }  from './Account.component';
import { LoginComponent }    from './Login/Login.component';
import { RegisterComponent } from './Register/Register.component';

@NgModule({
  imports: [
    CommonModule,
    DashboardModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot([
      { path: "Account",          component: AccountComponent },
      { path: "Account/Login",    component: LoginComponent },
      { path: "Account/Register", component: RegisterComponent },
    ]),
  ],
  declarations: [
    AccountComponent,
    LoginComponent,
    RegisterComponent
],
  exports: [AccountComponent, LoginComponent, RegisterComponent]
})
export class AccountModule { }