import { Profile } from "./Profile";
import { Manufacturers } from "../Enums/Manufacturers.enum";

export class Manufacturer extends Profile {
    public Company: Manufacturers;
    constructor() { super(); }

    public GetManufacturer(): string {
        return this.Company.toString();
    }
}
