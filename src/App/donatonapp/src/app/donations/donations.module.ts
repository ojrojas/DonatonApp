import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DonationsRoutingModule } from './donations-routing.module';
import { ContainerComponent } from './container/container.component';
import { DonationMoneyComponent } from './components/forms/donation-money/donation-money.component';
import { DonationPerishableComponent } from './components/forms/donation-perishable/donation-perishable.component';
import { DonationNonPerishableComponent } from './components/forms/donation-non-perishable/donation-non-perishable.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import * as fromReducer from './store/donations.reducer';
import { StoreModule } from '@ngrx/store';
import { EffectsModule } from '@ngrx/effects';
import { DonationsEffects } from './store/donations.effects';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [
    ContainerComponent,
    DonationMoneyComponent,
    DonationPerishableComponent,
    DonationNonPerishableComponent,
    DashboardComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    DonationsRoutingModule,
    StoreModule.forFeature(fromReducer.donationsFeatureKey, fromReducer.reducer),
    EffectsModule.forFeature([DonationsEffects])
  ]
})
export class DonationsModule { }
