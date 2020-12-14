import { createFeatureSelector, createSelector } from '@ngrx/store';
import * as fromReducer from './donations.reducer';

export const getStateDonations = createFeatureSelector<fromReducer.State>(fromReducer.donationsFeatureKey);

export const getDonationMoneys = createSelector(
    getStateDonations,
    (state) => state.donationMoneys
);

export const getDonationPerishables = createSelector(
    getStateDonations,
    (state) => state.donationPerishables
);

export const getDonationNonPerishables = createSelector(
    getStateDonations,
    (state) => state.donationNonPerishables
);
