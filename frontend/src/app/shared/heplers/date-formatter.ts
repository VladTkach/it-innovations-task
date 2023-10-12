export class DateFormatter {
  static formatDate(dateObject: Date) {
    const year = dateObject.getFullYear();
    const month = dateObject.getMonth() + 1; // Додаємо 1, оскільки місяці в JavaScript починаються з 0
    const day = dateObject.getDate();
    const hours = dateObject.getHours();
    const minutes = dateObject.getMinutes();
    const seconds = dateObject.getSeconds();
    const milliseconds = dateObject.getMilliseconds();

    return new Date(`${year}-${month.toString().padStart(2, '0')}-${day.toString().padStart(2, '0')}T${hours.toString().padStart(2, '0')}:${minutes.toString().padStart(2, '0')}:${seconds.toString().padStart(2, '0')}.${milliseconds}Z`);
  }
}
