import { Component, OnInit } from '@angular/core';
import { EmployeeComponent } from '../Employee/Employee.component';

@Component({
  selector: 'app-Admin',
  templateUrl: './Admin.component.html',
  styleUrls: ['./Admin.component.css']
})
export class AdminComponent extends EmployeeComponent implements OnInit {

  constructor() { super(); }

  ngOnInit() {
  }

}
