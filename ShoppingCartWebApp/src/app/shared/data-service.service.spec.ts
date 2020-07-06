import { TestBed } from '@angular/core/testing';

import { DataServiceService } from './data-service.service';

/*describe('DataServiceService', () => {
  let service: DataServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DataServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});*/

import { HttpClientModule } from '@angular/common/http';
import {
  HttpTestingController,
  HttpClientTestingModule,
} from '@angular/common/http/testing';

describe('#getUsers', () => {
  let service: DataServiceService;
  let httpMock: HttpTestingController;
  it('should return an Observable<User[]>', () => {
    const dummyCategories: any[] = [{ Id: 1 }, { CategoryName: 'Foods' }];

    service.loadCategories().subscribe((categories) => {
      expect(categories.valueOf.length).toBe(2);
      expect(categories).toEqual(dummyCategories);
    });

    const req = httpMock.expectOne(`${service.BaseURI}/categories`);
    expect(req.request.method).toBe('GET');
    req.flush(dummyCategories);
  });
});
