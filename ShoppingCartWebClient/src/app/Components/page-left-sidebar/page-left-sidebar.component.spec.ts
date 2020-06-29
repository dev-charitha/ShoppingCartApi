import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PageLeftSidebarComponent } from './page-left-sidebar.component';

describe('PageLeftSidebarComponent', () => {
  let component: PageLeftSidebarComponent;
  let fixture: ComponentFixture<PageLeftSidebarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PageLeftSidebarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PageLeftSidebarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
