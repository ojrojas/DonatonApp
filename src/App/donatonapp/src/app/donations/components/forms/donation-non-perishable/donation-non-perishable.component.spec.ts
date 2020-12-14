import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DonationNonPerishableComponent } from './donation-non-perishable.component';

describe('DonationNonPerishableComponent', () => {
  let component: DonationNonPerishableComponent;
  let fixture: ComponentFixture<DonationNonPerishableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DonationNonPerishableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DonationNonPerishableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
