import { Component, OnInit } from '@angular/core';
import { DataService }       from '../../_Shared/Services/Data.service';
import { AccountComponent }  from '../Account.component';

@Component({
  selector: 'app-Register',
  templateUrl: './Register.component.html',
  styleUrls: ['./Register.component.css']
})
export class RegisterComponent extends AccountComponent implements OnInit {
  constructor(public service: DataService) { super(service); }

  ngOnInit() {
  }

}
