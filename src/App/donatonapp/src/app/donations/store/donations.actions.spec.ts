import * as fromDonations from './donations.actions';

describe('loadDonationss', () => {
  it('should return an action', () => {
    expect(fromDonations.loadDonationss().type).toBe('[Donations] Load Donationss');
  });
});
