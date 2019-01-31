import { Component, OnInit } from '@angular/core';
import { CustomerComponent } from '../Customer/Customer.component';

@Component({
  selector: 'app-Employee',
  templateUrl: './Employee.component.html',
  styleUrls: ['./Employee.component.css']
})
export class EmployeeComponent extends CustomerComponent implements OnInit {

  constructor() { super(); }

  ngOnInit() {
  }

}
