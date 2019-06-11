import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Subject } from 'src/app/models/subject.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SubjectsService {

  constructor(private httpClient: HttpClient) { }

  getSubjects(programId: string) {
    return this.httpClient.get<Subject[]>(`${environment.baseUrl}/programs/${programId}`);
  }
}
