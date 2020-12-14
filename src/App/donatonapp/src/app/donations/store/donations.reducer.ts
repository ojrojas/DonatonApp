import { Action, createReducer, on } from '@ngrx/store';
import { DonationMoney } from 'src/app/models/donation-money.model';
import { DonationNonPerishable } from 'src/app/models/donation-non-perishable.model';
import { DonationPerishable } from 'src/app/models/donation-perishable.model';
import { StateMaterial } from 'src/app/models/state-material.model';
import { TypeDonation } from 'src/app/models/typedonation.model';
import { TypeIdentification } from 'src/app/models/typeidentification.model';
import * as fromActions from './donations.actions';

export const donationsFeatureKey = 'donations';

export interface State {
  isLoading: boolean;
  donationMoneys: DonationMoney[];
  donationPerishables: DonationPerishable[];
  donationNonPerishables: DonationNonPerishable[];
  error: any;
  donationMoney: DonationMoney;
  donationPerishable: DonationPerishable;
  donationNonPerishable: DonationNonPerishable;
  stateMaterials: StateMaterial[];
  typeDonations: TypeDonation[];
  typeIdentifications: TypeIdentification[];
}

export const initialState: State = {
  isLoading: false,
  donationMoneys: [],
  donationPerishables: [],
  donationNonPerishables: [],
  error: null,
  donationMoney: null,
  donationPerishable: null,
  donationNonPerishable: null,
  stateMaterials: [],
  typeDonations: [],
  typeIdentifications: []
};

export const reducer = createReducer(
  initialState,
  on(fromActions.loadDonationsMoney, (state) => ({
    ...state,
    isLoading: true
  })),
  on(fromActions.loadDonationsMoneySuccess, (state, { donationMoneys }) => ({
    ...state,
    donationMoneys,
    isLoading: false
  })),
  on(fromActions.loadDonationsMoneyFailure, (state, { error }) => ({
    ...state,
    isLoading: false,
    error,
  })),
  on(fromActions.loadDonationsPerishable, (state) => ({
    ...state,
    isLoading: true
  })),
  on(fromActions.loadDonationsPerishableSuccess, (state, { donationPerishables }) => ({
    ...state,
    donationPerishables,
    isLoading: false
  })),
  on(fromActions.loadDonationsPerishableFailure, (state, { error }) => ({
    ...state,
    isLoading: false,
    error,
  })),
  on(fromActions.loadDonationsNonPerishable, (state) => ({
    ...state,
    isLoading: true
  })),
  on(fromActions.loadDonationsNonPerishableSuccess, (state, { donationNonPerishables }) => ({
    ...state,
    donationNonPerishables,
    isLoading: false
  })),
  on(fromActions.loadDonationsNonPerishableFailure, (state, { error }) => ({
    ...state,
    isLoading: false,
    error,
  })),
  on(fromActions.createDonationsMoney, (state, { donationMoney }) => ({
    ...state,
    donationMoney,
    isLoading: true
  })),
  on(fromActions.createDonationsMoneySuccess, (state, { donationMoney }) => ({
    ...state,
    donationMoney,
    isLoading: false
  })),
  on(fromActions.createDonationsMoneyFailure, (state, { error }) => ({
    ...state,
    isLoading: false,
    error,
  })),
  on(fromActions.createDonationsPerishable, (state, { donationPerishable }) => ({
    ...state,
    donationPerishable,
    isLoading: true
  })),
  on(fromActions.createDonationsPerishableSuccess, (state, { donationPerishable }) => ({
    ...state,
    donationPerishable,
    isLoading: false
  })),
  on(fromActions.createDonationsPerishableFailure, (state, { error }) => ({
    ...state,
    isLoading: false,
    error,
  })),
  on(fromActions.createDonationsNonPerishable, (state, { donationNonPerishable }) => ({
    ...state,
    donationNonPerishable,
    isLoading: true
  })),
  on(fromActions.createDonationsNonPerishableSuccess, (state, { donationNonPerishable }) => ({
    ...state,
    donationNonPerishable,
    isLoading: false
  })),
  on(fromActions.createDonationsNonPerishableFailure, (state, { error }) => ({
    ...state,
    isLoading: false,
    error,
  })),
);

