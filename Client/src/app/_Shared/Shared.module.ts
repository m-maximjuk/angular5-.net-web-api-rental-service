import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule }  from '@angular/common';
import { HttpModule }    from '@angular/http';
import { ToastrModule }  from 'ngx-toastr';

import { SharedComponent } from './Shared.component';
import { DataService }     from './Services/Data.service';
import { MessageService }  from './Services/Message.service';

@NgModule({
  imports: [
    BrowserModule,
    CommonModule,
    HttpModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule,
],
  providers: [DataService, MessageService],
  declarations: [],
})
export class SharedModule { }