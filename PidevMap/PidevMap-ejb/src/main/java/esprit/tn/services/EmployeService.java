package esprit.tn.services;
/*/
import java.util.List;
import java.util.logging.Logger;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.NoResultException;
import javax.persistence.PersistenceContext;
import javax.persistence.TypedQuery;

import tn.esprit.imputation.entity.Contrat;
import tn.esprit.imputation.entity.Departement;
import tn.esprit.imputation.entity.Employe;

@Stateless
@LocalBean
/*/
public class EmployeService implements EmployeeServiceRemote {
/*/	
	@PersistenceContext
	EntityManager em;
	@Override
	public void ajouterEmployee(Employe e) {
		em.persist(e);	
	}

	@Override
	public List<Employe> findAll() {
		// TODO Auto-generated method stub
		
		return em.createQuery("from Employe" ,Employe.class).getResultList();
	}
	
	@Override
	public void DeleteEmployeById(int employeId) {
		em.remove(em.find(Employe.class,employeId));
		
	}
	
	
	@Override
	public void affecterEmployeADepartement(int employeId, int depId) {
		
		em.find(Departement.class, depId).getListeEmployes().add(em.find(Employe.class, employeId));
		
	}

	@Override
	public int ajouterContrat(Contrat contrat) {
			 
		em.persist(contrat);
		return contrat.getReference();
	}

	@Override
	public void affecterContratAEmploye(int contratId, int employeId) {
		em.find(Contrat.class, contratId).setEmploye(em.find(Employe.class, employeId));
	}

	@Override
	public String getEmployePrenomById(int employeId) {
		return em.find(Employe.class, employeId).getPrenom();
	}


	@Override
	public long getNombreEmployeJPQL() {
		
		  TypedQuery<Long> query = em.createQuery(
			   "SELECT COUNT(e) FROM Employe  e", Long.class);
			  long results =query.getSingleResult();
			  return results;
	}

	@Override
	public List<String> getAllEmployeNamesJPQL() {
		  TypedQuery<String> query = em.createQuery(
			      "SELECT e.nom FROM Employe  e", String.class);
			  List<String> results = query.getResultList();
			  return results;
	}

	@Override
	public Employe getEmployeByEmailAndPassword(String email, String password) {
		
		TypedQuery<Employe> query = em.createQuery("Select e from  Employe e " + 
		
				"where e.email=:email and " +
				"e.nom=:password" , Employe.class
				) ; 
		query.setParameter("email", email) ; 
		query.setParameter("password", password) ; 
		Employe	 employe = null ; 
		
		try {
			employe =  query.getSingleResult() ; 
			
		}catch(NoResultException e){
			System.out.println("error");
		} 
		
		return employe;
	}



	

/*/	
}
