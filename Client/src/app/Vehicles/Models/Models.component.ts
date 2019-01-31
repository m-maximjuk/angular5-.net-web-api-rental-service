import { Component, OnInit } from '@angular/core';
import { NgModel, NgForm }   from '@angular/forms';
import { VehiclesComponent } from '../Vehicles.component';
import { Vehicle }       from '../../_Shared/Models/Vehicle';
import { DataService }   from '../../_Shared/Services/Data.service';
import { MessageType }   from '../../_Shared/Services/Message.service';
import { Manufacturers } from '../../_Shared/Enums/Manufacturers.enum';
import { Transmissions } from '../../_Shared/Enums/Transmissions.enum';

@Component({
  selector: 'app-Models',
  templateUrl: './Models.component.html',
  styleUrls: ['./Models.component.css']
})
export class ModelsComponent extends VehiclesComponent implements OnInit {
  // Layout Fields
  public Layout = Layouts.Gallery;
  public ViewCount = 1;
  // Data Fields
  public query = new Query();
  public ModelList = new Array<Vehicle>();
  public DisplayList = new Array<Vehicle>();
  constructor(private service: DataService) { super(service); }

  ngOnInit() { this.GetModels(); }

  public async GetModels() { 
    await this.service.GetModels("Vehicles", result => { this.ModelList = result; this.DisplayList = result; }); 
  }
  public FilterList() {
    if (this.query.Search != null && this.query.Search.length > 0) { this.DisplayList = this.ModelList.filter(item => item.Model.toLowerCase().toLowerCase().includes(this.query.Search.toLowerCase().toLowerCase()) || item.Brand.toLowerCase().includes(this.query.Search.toLowerCase()) || item.Color.toLowerCase().includes(this.query.Search.toLowerCase()) || item.MarketPrice.toString().toLowerCase().includes(this.query.Search.toLowerCase()) || item.Model.toLowerCase().includes(this.query.Search.toLowerCase()) || item.Transmission.toLowerCase().includes(this.query.Search.toLowerCase()) || item.Year.toString().toLowerCase().includes(this.query.Search.toLowerCase())); } else { this.DisplayList = this.ModelList; }
    if (this.query.Model != null && this.query.Model.length > 0) { this.DisplayList = this.ModelList.filter(item => item.Model.toLowerCase().includes(this.query.Model.toLowerCase())); }
    if (this.query.MinPrice != null && this.query.MinPrice != 0) { this.DisplayList = this.ModelList.filter(item => item.MarketPrice >= this.query.MinPrice); }
    if (this.query.MaxPrice != null && this.query.MaxPrice != 0) { this.DisplayList = this.ModelList.filter(item => item.MarketPrice <= this.query.MaxPrice); }
    if (this.query.MaxPrice != null && this.query.MaxPrice != 0 && this.query.MinPrice != null && this.query.MinPrice != 0) { this.DisplayList = this.ModelList.filter(item => item.MarketPrice <= this.query.MaxPrice && item.MarketPrice >= this.query.MinPrice); }
    if (this.query.Manufacturer != null && this.query.Manufacturer.length > 0) { this.DisplayList = this.ModelList.filter(item => item.Brand.toLowerCase().includes(this.query.Manufacturer.toLowerCase())); }
    if (this.query.Transmission != null && this.query.Transmission.length > 0) { this.DisplayList = this.ModelList.filter(item => item.Transmission.toLowerCase().match(this.query.Transmission.toLowerCase())); }
    if (this.query.MinYear != null && this.query.MinYear != 0) { this.DisplayList = this.ModelList.filter(item => item.Year >= this.query.MinYear); }
    if (this.query.MaxYear != null && this.query.MaxYear != 0) { this.DisplayList = this.ModelList.filter(item => item.Year <= this.query.MaxYear); }
    if (this.query.MaxYear != null && this.query.MaxYear != 0 && this.query.MinYear != null && this.query.MinYear != 0) { this.DisplayList = this.ModelList.filter(item => item.Year >= this.query.MinYear && item.Year <= this.query.MaxYear); }
  }
  private Filter(param?: any, callback?: (item: Vehicle) => void) {
    this.DisplayList = this.ModelList.filter(callback);
  }
  public ClearFilter() { 
    this.query = new Query();
    this.DisplayList = this.ModelList;
  }
  public Transmission(option) {
    if (option) { this.query.Transmission = option; this.FilterList(); }
  }
}
export class Query {
  public Model?: string;
  public Manufacturer?: string;
  public Transmission?: string;
  public MinPrice?: number;
  public MaxPrice?: number;
  public MinYear?: number;
  public MaxYear?: number;
  public Search?: string;
  constructor() {}
}
export enum Layouts {
  Gallery = 0,
  Details
}
