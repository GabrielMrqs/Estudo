import { Photo } from './photo';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PhotoService {
  constructor(private http: HttpClient) {}

  urlAPI = 'https://localhost:7016/';

  getAll() {
    return this.http.get<Photo[]>(this.urlAPI + 'photos');
  }
}
