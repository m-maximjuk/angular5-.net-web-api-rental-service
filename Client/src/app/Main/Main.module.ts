import { NgModule }     from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { MainComponent }     from './Main.component';
import { HomeComponent }     from './Home/Home.component';
import { ContactComponent }  from './Contact/Contact.component';
import { AboutComponent }    from './About/About.component';
import { BranchesComponent } from './Branches/Branches.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot([
      { path: "",         component: HomeComponent },
      { path: "Home",     component: HomeComponent },
      { path: "Branches", component: BranchesComponent },
      { path: "About",    component: AboutComponent },
      { path: "Contact",  component: ContactComponent },
    ])
  ],
  declarations: [
    MainComponent,
    HomeComponent,
    ContactComponent,
    AboutComponent,
    BranchesComponent
],
  exports: [MainComponent]
})
export class MainModule { }