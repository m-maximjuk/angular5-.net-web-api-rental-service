import { Model } from "./Model";

export class Profile extends Model {
    public Picture:      string;
    public Description:  string;
    public ActiveSince?: Date;
    public ActiveLast?:  Date;
    public Contact: {
        Address: string;
        Longitude: number;
        Latitude: number;
        Phone: string;
        Email: string;
    }
}