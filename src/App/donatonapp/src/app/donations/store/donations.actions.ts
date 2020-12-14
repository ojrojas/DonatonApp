import { createAction, props } from '@ngrx/store';
import { DonationMoney } from 'src/app/models/donation-money.model';
import { DonationNonPerishable } from 'src/app/models/donation-non-perishable.model';
import { DonationPerishable } from 'src/app/models/donation-perishable.model';
import { EnumsModeForms } from 'src/app/models/enums.model';
import { StateMaterial } from 'src/app/models/state-material.model';
import { TypeDonation } from 'src/app/models/typedonation.model';
import { TypeIdentification } from 'src/app/models/typeidentification.model';

// Donations Dashboard
// Donations Money
export const loadDonationsMoney = createAction(
  '[Donations] Load Donationss Money'
);

export const loadDonationsMoneySuccess = createAction(
  '[Donations] Load Donationss Money Success',
  props<{ donationMoneys: DonationMoney[] }>()
);

export const loadDonationsMoneyFailure = createAction(
  '[Donations] Load Donationss Money Failure',
  props<{ error: any }>()
);

// Donations Perishable
export const loadDonationsPerishable = createAction(
  '[Donations] Load Donationss Perishable'
);

export const loadDonationsPerishableSuccess = createAction(
  '[Donations] Load Donationss Perishable Success',
  props<{ donationPerishables: DonationPerishable[] }>()
);

export const loadDonationsPerishableFailure = createAction(
  '[Donations] Load Donationss Perishable Failure',
  props<{ error: any }>()
);

// Donations Non Perishable
export const loadDonationsNonPerishable = createAction(
  '[Donations] Load Donationss Non Perishable'
);

export const loadDonationsNonPerishableSuccess = createAction(
  '[Donations] Load Donationss Non Perishable Success',
  props<{ donationNonPerishables: DonationNonPerishable[] }>()
);

export const loadDonationsNonPerishableFailure = createAction(
  '[Donations] Load Donationss Non Perishable Failure',
  props<{ error: any }>()
);

// Forms Donations Money
// Donations Money

export const createDonationsMoney = createAction(
  '[Donations] Create Donation Money',
  props<{ donationMoney: DonationMoney }>()
);

export const createDonationsMoneySuccess = createAction(
  '[Donations] Create Donation Money Success',
  props<{ donationMoney: DonationMoney }>()
);

export const createDonationsMoneyFailure = createAction(
  '[Donations] Create Donation Money Failure',
  props<{ error: any }>()
);

export const EditDonationsMoney = createAction(
  '[Donations] Edit Donation Money',
  props<{ donationMoney: DonationMoney }>()
);

export const EditDonationsMoneySuccess = createAction(
  '[Donations] Edit Donation Money Success',
  props<{ donationMoney: DonationMoney }>()
);

export const EditDonationsMoneyFailure = createAction(
  '[Donations] Edit Donation Money Failure',
  props<{ error: any }>()
);

export const DeleteDonationsMoney = createAction(
  '[Donations] Delete Donation Money',
  props<{ donationMoney: DonationMoney }>()
);

export const DeleteDonationsMoneySuccess = createAction(
  '[Donations] Delete Donation Money Success',
  props<{ donationMoney: DonationMoney }>()
);

export const DeleteDonationsMoneyFailure = createAction(
  '[Donations] Delete Donation Money Failure',
  props<{ error: any }>()
);

// Forms Donations Perishable
// Donations Perishable

export const createDonationsPerishable = createAction(
  '[Donations] Create Donation Perishable',
  props<{ donationPerishable: DonationPerishable }>()
);

export const createDonationsPerishableSuccess = createAction(
  '[Donations] Create Donation Perishable Success',
  props<{ donationPerishable: DonationPerishable }>()
);

export const createDonationsPerishableFailure = createAction(
  '[Donations] Create Donation Perishable Failure',
  props<{ error: any }>()
);

export const EditDonationsPerishable = createAction(
  '[Donations] Edit Donation Perishable',
  props<{ donationPerishable: DonationPerishable }>()
);

export const EditDonationsPerishableSuccess = createAction(
  '[Donations] Edit Donation Perishable Success',
  props<{ donationPerishable: DonationPerishable }>()
);

export const EditDonationsPerishableFailure = createAction(
  '[Donations] Edit Donation Perishable Failure',
  props<{ error: any }>()
);

export const DeleteDonationsPerishable = createAction(
  '[Donations] Delete Donation Perishable',
  props<{ donationPerishable: DonationPerishable }>()
);

export const DeleteDonationsPerishableSuccess = createAction(
  '[Donations] Delete Donation Perishable Success',
  props<{ donationPerishable: DonationPerishable }>()
);

export const DeleteDonationsPerishableFailure = createAction(
  '[Donations] Delete Donation Perishable Failure',
  props<{ error: any }>()
);

// Forms Donations Non Perishable
// Donations NonPerishable

export const createDonationsNonPerishable = createAction(
  '[Donations] Create Donation NonPerishable',
  props<{ donationNonPerishable: DonationNonPerishable }>()
);

export const createDonationsNonPerishableSuccess = createAction(
  '[Donations] Create Donation NonPerishable Success',
  props<{ donationNonPerishable: DonationNonPerishable }>()
);

export const createDonationsNonPerishableFailure = createAction(
  '[Donations] Create Donation NonPerishable Failure',
  props<{ error: any }>()
);

export const EditDonationsNonPerishable = createAction(
  '[Donations] Edit Donation NonPerishable',
  props<{ donationNonPerishable: DonationNonPerishable }>()
);

export const EditDonationsNonPerishableSuccess = createAction(
  '[Donations] Edit Donation NonPerishable Success',
  props<{ donationNonPerishable: DonationNonPerishable }>()
);

export const EditDonationsNonPerishableFailure = createAction(
  '[Donations] Edit Donation NonPerishable Failure',
  props<{ error: any }>()
);

export const DeleteDonationsNonPerishable = createAction(
  '[Donations] Delete Donation NonPerishable',
  props<{ donationNonPerishable: DonationNonPerishable }>()
);

export const DeleteDonationsNonPerishableSuccess = createAction(
  '[Donations] Delete Donation NonPerishable Success',
  props<{ donationNonPerishable: DonationNonPerishable }>()
);

export const DeleteDonationsNonPerishableFailure = createAction(
  '[Donations] Delete Donation NonPerishable Failure',
  props<{ error: any }>()
);

// Launch Form Modals

// LaunchForm DonationMoney
export const LaunchFormModalDonationMoney = createAction(
  '[Donations] Lanch Form Modal Donation Money',
  props<{ donationMoney: DonationMoney, mode: EnumsModeForms, title: string }>()
);

// LaunchForm DonationPerishable
export const LaunchFormModalDonationPerishable = createAction(
  '[Donations] Launch Form Modal Donation Perishable',
  props<{ donationPerishable: DonationPerishable, mode: EnumsModeForms, title: string }>()
);

// LaunchForm DonationNonPerishable
export const LaunchFormModalDonationNonPerishable = createAction(
  '[Donations] Launch Form Modal Donation Non Perishable',
  props<{ donationNonPerishable: DonationNonPerishable, mode: EnumsModeForms, title: string }>()
);

// Load Transversals
export const loadStateMaterial = createAction(
  '[Donations] load State Material'
);

export const loadStateMaterialSuccess = createAction(
  '[Donations] load State Material Success',
  props<{stateMaterials: StateMaterial[]}>()
);

export const loadStateMaterialFailure = createAction(
  '[Donations] load State Material Failure',
  props<{error: any}>()
);

export const loadTypeDonation = createAction(
  '[Donations] load Type Donations'
);

export const loadTypeDonationSuccess = createAction(
  '[Donations] load Type Donations Success',
  props<{typeDonations: TypeDonation[]}>()
);

export const loadTypeDonationFailure = createAction(
  '[Donations] load Type Donations Failure',
  props<{error: any}>()
);

export const loadTypeIdentification = createAction(
  '[Donations] load Type Identification'
);

export const loadTypeIdentificationSuccess = createAction(
  '[Donations] load type Identification Success',
  props<{typeIdentifications: TypeIdentification[] }>()
);

export const loadTypeIdentificationFailure = createAction(
  '[Donations] load type Identification Failure',
  props<{error: any }>()
);





