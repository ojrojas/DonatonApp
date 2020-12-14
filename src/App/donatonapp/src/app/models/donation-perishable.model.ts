import { DonationNonPerishableAndPerishable } from "./donation-non-perishable-and-perishable.model";

export interface DonationPerishable extends DonationNonPerishableAndPerishable {
    description: string;
    quantity: number;
    unitMeasurement: string;
    dateExpiration: Date;
}