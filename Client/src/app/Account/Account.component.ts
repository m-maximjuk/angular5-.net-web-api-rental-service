import { Component, OnInit } from '@angular/core';
import { Account }           from '../_Shared/Models/Account';
import { DataService }       from '../_Shared/Services/Data.service';

@Component({
  selector: 'app-Account',
  templateUrl: './Account.component.html',
  styleUrls: ['./Account.component.css']
})
export class AccountComponent implements OnInit {
  public account = new Account();
  constructor(public Service: DataService) { }

  ngOnInit() {
  }

}