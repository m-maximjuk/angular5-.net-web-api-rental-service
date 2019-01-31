import { Component, OnInit } from '@angular/core';
import { Account } from '../../_Shared/Models/Account';

@Component({
  selector: 'app-Dashboard',
  templateUrl: './Dashboard.component.html',
  styleUrls: ['./Dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  public account: Account;
  constructor() { }
  
  ngOnInit() { 
    this.account = JSON.parse(localStorage.getItem("Account"));
  }

}
