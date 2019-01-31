import { User }  from "./User"; 
import { Model } from "./Model";

export class Account extends Model {
    public Username: string;
    public Password: string;
    public User: any;

    constructor () { super();
    }
}


