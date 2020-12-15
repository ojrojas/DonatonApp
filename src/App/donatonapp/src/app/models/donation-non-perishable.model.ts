import { DonationNonPerishableAndPerishable } from './donation-non-perishable-and-perishable.model';
import { StateMaterial } from './state-material.model';

export interface DonationNonPerishable extends DonationNonPerishableAndPerishable {
    description: string;
    weight: number;
    stateMaterial: StateMaterial;
    stateMaterialId: string;
}
