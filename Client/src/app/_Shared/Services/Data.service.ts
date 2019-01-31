import { Http, Response, RequestOptions, Headers }   from '@angular/http';
import { MessageService, MessageType, IMessageArgs } from './Message.service';
import { Injectable }    from '@angular/core';
import { Observable }    from 'rxjs/Observable';
import { ToastrService } from 'ngx-toastr';
import { Subscription }  from 'rxjs/Subscription';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable()
export class DataService {
    public isLoaded = false;
    public loading = "http://it.bogaert.net/images/preloader02.gif";
    public error = new ErrorArgs();
    
    constructor(private http: Http, public message: MessageService) { this.error.hasError = false; }
    
    //#region CRUD Methods
    public async Create(controller: string, model: any, callback?: (model: any) => void): Promise<Subscription> {
        return await this.http
            .post(this.Route(controller), model, this.Requests())
            .subscribe((response: Response) => {
                this.isLoaded = true;
                return callback(response.json()); }, 
                (error: Response) => { 
                    this.Handler(error); } );
    }
    public async GetModel(controller: string, id: number, callback?: (model: any) => void): Promise<Subscription> {
        return await this.http
            .get(this.Route(controller) + id, this.Requests())
            .subscribe((response: Response) => {
                this.isLoaded = true;
                return callback(response.json()); }, 
                (error: Response) => { 
                    this.Handler(error); } );
    }
    public async GetModels(controller: string, callback?: (model: any) => void): Promise<Subscription> {
        console.log("Getting Models..");
        
        return await this.http
            .get(this.Route(controller), this.Requests())
            .subscribe((response: Response) => {
                this.isLoaded = true;
                return callback(response.json()); }, 
                (error: Response) => { 
                    this.Handler(error); } );
    }
    public async Update(controller: string, id: number, model: any, callback?: (model: any) => void): Promise<Subscription> {
        return await this.http
            .put(this.Route(controller), model, this.Requests())
            .subscribe((response: Response) => {
                this.isLoaded = true;
                return callback(response.json()); }, 
                (error: Response) => { 
                    this.Handler(error);} );
    }
    public async Delete(controller: string, id: number, callback?: (model: any) => void): Promise<Subscription> {
        return await this.http
            .delete(this.Route(controller) + id, this.Requests())
            .subscribe((response: Response) => {
                this.isLoaded = true;
                return callback(response.json()); }, 
                (error: Response) => { 
                    this.Handler(error); } );
    }
    public async Request(controller: string, model: any, callback?: (model: any) => void): Promise<Subscription> {
        return await this.http
            .request(this.Route(controller) + model, this.Requests())
            .subscribe((response: Response) => {
                this.isLoaded = true;
                return callback(response.json()); }, 
                (error: Response) => { 
                    this.Handler(error); } );
    }
    //#endregion CRUD Methods

    private Route(controller: string) : string { return "http://localhost:56004/api/" + controller + '/'; }
    private Requests(): RequestOptions { return new RequestOptions({ headers: new Headers({'Content-type': 'application/json'}) }); }

    private Handler(error: Response): void {
        this.isLoaded = true;
        this.error = { hasError: true, details: { message: error.json().Message, title: "Failure!", option: MessageType.Error } };
        this.message.Display(this.error.details);
     }
}
export class ErrorArgs {
    details?: IMessageArgs;
    hasError: boolean;
    constructor() {}
}