import { TestBed } from '@angular/core/testing';

import { AccesoperfilService } from './accesoperfil.service';

describe('AccesoperfilService', () => {
  let service: AccesoperfilService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AccesoperfilService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
