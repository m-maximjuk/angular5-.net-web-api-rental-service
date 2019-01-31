import { Component } from '@angular/core';
import { AccountComponent }  from '../Account.component';
import { DataService }       from '../../_Shared/Services/Data.service';
import { MessageType } from '../../_Shared/Services/Message.service';
import { Account } from '../../_Shared/Models/Account';

@Component({
  selector: 'app-Login',
  templateUrl: './Login.component.html',
  styleUrls: ['./Login.component.css']
})
export class LoginComponent extends AccountComponent {
  constructor(public service: DataService) { super(service);
    console.log("Login Component Constructor");
  }

  public async Login() { 
    console.log("Logging In");
    this.service.message.Display({title: "Logging In", message: "Please Wait..", option: MessageType.Info})

    await this.service.Create("Connections", this.account, result => {
      this.account = result;
      localStorage.setItem("Account", JSON.stringify(result));
      this.service.message.Display({title: "Logged In Succesfully", message: "Welcome " + this.account.Username + " !", option: MessageType.Success});
    });
  }
  public CloseLogin() {
    this.account = new Account();
  }
}
