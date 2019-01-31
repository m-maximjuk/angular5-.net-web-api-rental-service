import { Component, OnInit } from '@angular/core';
import { Manufacturer } from '../_Shared/Models/Manufacturer';
import { Vehicle }      from '../_Shared/Models/Vehicle';
import { DataService }  from '../_Shared/Services/Data.service';

@Component({
  selector: 'app-Vehicles',
  templateUrl: './Vehicles.component.html',
  styleUrls: ['./Vehicles.component.css']
})
export class VehiclesComponent implements OnInit {
  public BrandList = new Array<Manufacturer>();
  constructor(public Service: DataService) { }

  ngOnInit() { this.GetBrands(); }

  public async GetBrands() { await this.Service.GetModels("Manufacturers", result => { this.BrandList = result; }); }
}