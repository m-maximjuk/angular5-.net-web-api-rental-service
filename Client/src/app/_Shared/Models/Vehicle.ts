import { Profile } from "./Profile";
import { Vehicles } from "../Enums/Vehicles.enum";
import { Transmissions } from "../Enums/Transmissions.enum";
import { Colors } from "../Enums/Colors.enum";
import { Branch } from "./Branch";
import { Manufacturer } from "./Manufacturer";

export class Vehicle extends Profile {
    // Relationships
    public BranchID: number;
    public ManufacturerID: number;
    // Properties
    public Model: string;
    public Brand: string;
    public Transmission: string;
    public Color: string;
    public LicenseID: string;
    public Mileage: number;
    public Owners: number;
    public Year: number;
    public MarketPrice: number;

    constructor() { super(); }

    public GetModel(): string {
        return this.Model.toString();
    }
    public GetColor(): string {
        return this.Color.toString();
    }
    public GetTransmission(): string {
        return this.Transmission.toString();
    }

}
