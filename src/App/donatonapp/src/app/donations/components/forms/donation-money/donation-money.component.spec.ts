import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DonationMoneyComponent } from './donation-money.component';

describe('DonationMoneyComponent', () => {
  let component: DonationMoneyComponent;
  let fixture: ComponentFixture<DonationMoneyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DonationMoneyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DonationMoneyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
