import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarMake } from './car-make';

describe('CarMake', () => {
  let component: CarMake;
  let fixture: ComponentFixture<CarMake>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CarMake]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CarMake);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
