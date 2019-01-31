import { Component, OnInit } from '@angular/core';
import { Account } from '../_Shared/Models/Account';
import { Router } from '@angular/router';
import { DataService } from '../_Shared/Services/Data.service';
import { MessageType } from '../_Shared/Services/Message.service';

@Component({
  selector: 'app-Navbar',
  templateUrl: './Navbar.component.html',
  styleUrls: ['./Navbar.component.css']
})
export class NavbarComponent implements OnInit {
  public account: Account;
  constructor(private service: DataService, private router: Router) { }

  ngOnInit() {
  }

  public AccountCheck(): boolean { 
    if (localStorage.getItem("Account") != null) {
      this.account = JSON.parse(localStorage.getItem("Account"));
      return true;
    } else { return false; }
  }
  public Logout() {
    localStorage.clear();
    this.router.navigate(['/Home']);
    this.service.message.Display({title: "Logged Out Successfully", message: "Goodbye " + this.account.Username + "!", option: MessageType.Success});
  }
}
