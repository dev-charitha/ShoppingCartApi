import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PageShopContentComponent } from './page-shop-content.component';

describe('PageShopContentComponent', () => {
  let component: PageShopContentComponent;
  let fixture: ComponentFixture<PageShopContentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PageShopContentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PageShopContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
